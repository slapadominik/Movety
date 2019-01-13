package com.example.domin.movety;

import android.Manifest;
import android.annotation.SuppressLint;
import android.content.Context;
import android.content.DialogInterface;
import android.content.pm.PackageManager;
import android.graphics.Color;
import android.location.Location;
import android.net.Uri;
import android.os.Build;
import android.os.Bundle;
import android.os.Looper;
import android.support.annotation.NonNull;
import android.support.annotation.Nullable;
import android.support.constraint.ConstraintLayout;
import android.support.v4.app.ActivityCompat;
import android.support.v4.app.Fragment;
import android.support.v4.content.ContextCompat;
import android.support.v7.app.AlertDialog;
import android.support.v7.widget.LinearLayoutManager;
import android.util.Log;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.FrameLayout;
import android.widget.LinearLayout;
import android.widget.TextView;
import android.widget.Toast;

import com.example.domin.movety.api.MovetyApiClient;
import com.example.domin.movety.api.output.TrainingProposal;
import com.example.domin.movety.api.output.TrainingProposalLike;
import com.example.domin.movety.security.Authentication;
import com.google.android.gms.location.FusedLocationProviderClient;
import com.google.android.gms.location.LocationCallback;
import com.google.android.gms.location.LocationRequest;
import com.google.android.gms.location.LocationResult;
import com.google.android.gms.location.LocationServices;
import com.google.android.gms.maps.CameraUpdateFactory;
import com.google.android.gms.maps.GoogleMap;
import com.google.android.gms.maps.MapView;
import com.google.android.gms.maps.MapsInitializer;
import com.google.android.gms.maps.OnMapReadyCallback;
import com.google.android.gms.maps.SupportMapFragment;
import com.google.android.gms.maps.model.BitmapDescriptor;
import com.google.android.gms.maps.model.BitmapDescriptorFactory;
import com.google.android.gms.maps.model.CameraPosition;
import com.google.android.gms.maps.model.CircleOptions;
import com.google.android.gms.maps.model.LatLng;
import com.google.android.gms.maps.model.Marker;
import com.google.android.gms.maps.model.MarkerOptions;
import com.google.android.gms.tasks.OnCompleteListener;
import com.google.android.gms.tasks.Task;
import com.google.gson.Gson;
import com.google.gson.GsonBuilder;

import java.text.DateFormat;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;
import retrofit2.Retrofit;
import retrofit2.converter.gson.GsonConverterFactory;

import static android.support.constraint.Constraints.TAG;


/**
 * A simple {@link Fragment} subclass.
 * Activities that contain this fragment must implement the
 * {@link MapsFragment.OnFragmentInteractionListener} interface
 * to handle interaction events.
 * Use the {@link MapsFragment#newInstance} factory method to
 * create an instance of this fragment.
 */
public class MapsFragment extends Fragment implements OnMapReadyCallback {

    private GoogleMap mGoogleMap;
    private View mView;
    private MapView mapView;
    private boolean mLocationPermissionsGranted = false;
    private FusedLocationProviderClient mFusedLocationProviderClient;
    private String TAG = "MAPS_TAG";
    private static final float DEFAULT_ZOOM = 15f;
    private ConstraintLayout trainingProposalDetailsView;
    private List<com.example.domin.movety.api.output.TrainingProposal> trainingProposals = new ArrayList<>();
    private HashMap<Marker, Integer> mHashMap = new HashMap<Marker, Integer>();
    private TextView tv_marker_training_title;
    private TextView tv_marker_training_author;
    private TextView tv_marker_training_datefrom;
    private TextView tv_marker_training_dateto;
    private Button btn_marker_training_like_btn;
    private MovetyApiClient client;


    public static final int MY_PERMISSIONS_REQUEST_LOCATION = 99;

    public MapsFragment() {
    }

    // TODO: Rename and change types and number of parameters
    public static MapsFragment newInstance() {
        return new MapsFragment();
    }


    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        mView = inflater.inflate(R.layout.fragment_maps, container, false);
        trainingProposalDetailsView = mView.findViewById(R.id.my_info_window);
        tv_marker_training_title = mView.findViewById(R.id.marker_training_title);
        tv_marker_training_author = mView.findViewById(R.id.marker_training_author);
        tv_marker_training_datefrom = mView.findViewById(R.id.marker_training_datefrom);
        tv_marker_training_dateto = mView.findViewById(R.id.marker_training_dateto);
        btn_marker_training_like_btn = mView.findViewById(R.id.marker_training_like_btn);
        Gson gson = new GsonBuilder().serializeNulls().setDateFormat(DateFormat.LONG).create();

        Retrofit.Builder builder = new Retrofit.Builder()
                .baseUrl("https://movetyapi.azurewebsites.net/")
                .addConverterFactory(GsonConverterFactory.create(gson));
        Retrofit retrofit = builder.build();

        client = retrofit.create(MovetyApiClient.class);
        getLocationPermisssion();
        return mView;
    }


    @Override
    public void onMapReady(GoogleMap googleMap) {
        Log.d(TAG, "onMapReady: map is ready");
        mGoogleMap = googleMap;

        if (mLocationPermissionsGranted) {
            getDeviceLocation();

            if (ActivityCompat.checkSelfPermission(getContext(), Manifest.permission.ACCESS_FINE_LOCATION)
                    != PackageManager.PERMISSION_GRANTED && ActivityCompat.checkSelfPermission(getContext(),
                    Manifest.permission.ACCESS_COARSE_LOCATION) != PackageManager.PERMISSION_GRANTED) {
                return;
            }
            mGoogleMap.setMyLocationEnabled(true);
            mGoogleMap.getUiSettings().setMyLocationButtonEnabled(false);
            getTrainingProposalsFromApi(mGoogleMap);
        }
    }

    private void getTrainingProposalsFromApi(GoogleMap mGoogleMap){

        Call<List<com.example.domin.movety.api.output.TrainingProposal>> call = client.getNewTrainingProposalsForUser(Authentication.CLINET_ID);

        call.enqueue(new Callback<List<com.example.domin.movety.api.output.TrainingProposal>>() {
            @Override
            public void onResponse(Call<List<com.example.domin.movety.api.output.TrainingProposal>> call, Response<List<TrainingProposal>> response) {
                Log.i("MOVETYAPI", "size: "+response.body());
                trainingProposals = response.body();
                for (int i=0; i<trainingProposals.size(); i++){
                    Log.i("MOVETYAPI", trainingProposals.get(i).toString());
                    TrainingProposal trainingprop = trainingProposals.get(i);
                    Marker marker = mGoogleMap.addMarker(new MarkerOptions()
                            .position(new LatLng(trainingprop.getLocation().getLatitude(), trainingprop.getLocation().getLongitude()))
                            .title(trainingprop.getTitle())
                            .icon(BitmapDescriptorFactory.fromResource(R.mipmap.ic_bike_map)));
                    mHashMap.put(marker, i);
                }
            }

            @Override
            public void onFailure(Call<List<com.example.domin.movety.api.output.TrainingProposal>> call, Throwable t) {
                Toast.makeText(getContext(), "Error: cos poszlo nie tak", Toast.LENGTH_SHORT).show();
            }
        });

    }

    private void initMap(){
        Log.d(TAG, "initMap: initializing map");

        mapView = mView.findViewById(R.id.map);
        if (mapView != null){
            mapView.onCreate(null);
            mapView.onResume();
            mapView.getMapAsync(this);

        }
    }

    private void getDeviceLocation(){
        mFusedLocationProviderClient = LocationServices.getFusedLocationProviderClient(getContext());
        try{
            if(mLocationPermissionsGranted){

                final Task location = mFusedLocationProviderClient.getLastLocation();
                location.addOnCompleteListener(new OnCompleteListener() {
                    @Override
                    public void onComplete(@NonNull Task task) {
                        if(task.isSuccessful()){
                            Log.d(TAG, "onComplete: found location!");
                            Location currentLocation = (Location) task.getResult();

                            moveCamera(new LatLng(currentLocation.getLatitude(), currentLocation.getLongitude()),
                                    DEFAULT_ZOOM, "Tu jesteś");

                        }else{
                            Log.d(TAG, "onComplete: current location is null");
                            Toast.makeText(getActivity(), "unable to get current location", Toast.LENGTH_SHORT).show();
                        }
                    }
                });
            }
        }catch (SecurityException e){
            Log.e(TAG, "getDeviceLocation: SecurityException: " + e.getMessage() );
        }
    }

    private void moveCamera(LatLng latLng, float zoom, String title){
        Log.d(TAG, "moveCamera: moving the camera to: lat: " + latLng.latitude + ", lng: " + latLng.longitude );
        mGoogleMap.moveCamera(CameraUpdateFactory.newLatLngZoom(latLng, zoom));

        MarkerOptions options = new MarkerOptions()
                .position(latLng)
                .title(title);


        CircleOptions circleOptions = new CircleOptions()
                .center(latLng)
                .radius(500)
                .strokeWidth(2)
                .strokeColor(Color.BLUE)
                .fillColor(Color.parseColor("#500084d3"));
        CustomInfoWindowGoogleMap customInfoWindow = new CustomInfoWindowGoogleMap(getContext());
        mGoogleMap.setInfoWindowAdapter(customInfoWindow);

        mGoogleMap.setOnMapClickListener(new GoogleMap.OnMapClickListener() {
            @Override
            public void onMapClick(LatLng latLng) {
                trainingProposalDetailsView.setVisibility(View.GONE);
            }
        });
        mGoogleMap.setOnMarkerClickListener(new GoogleMap.OnMarkerClickListener() {
            @Override
            public boolean onMarkerClick(Marker marker) {
                int pos = mHashMap.get(marker);
                TrainingProposal trainingProposal = trainingProposals.get(pos);
                if (trainingProposal != null){
                    trainingProposalDetailsView.setVisibility(View.VISIBLE);
                    tv_marker_training_title.setText(trainingProposal.getTitle());
                    tv_marker_training_author.setText(trainingProposal.getAuthor().getFirstName()+" "+trainingProposal.getAuthor().getLastName());
                    tv_marker_training_datefrom.setText(trainingProposal.getDatetimeFrom());
                    tv_marker_training_dateto.setText(trainingProposal.getDatetimeTo());
                    btn_marker_training_like_btn.setOnClickListener(new View.OnClickListener() {
                        @Override
                        public void onClick(View v) {
                            Call<TrainingProposalLike> call = client.addTrainingProposalLike(new TrainingProposalLike(Authentication.CLINET_ID, trainingProposal.getId()));
                            call.enqueue(new Callback<TrainingProposalLike>() {
                                @Override
                                public void onResponse(Call<TrainingProposalLike> call, Response<TrainingProposalLike> response) {
                                    Toast.makeText(getActivity(), "Like added!", Toast.LENGTH_SHORT).show();
                                }

                                @Override
                                public void onFailure(Call<TrainingProposalLike> call, Throwable t) {
                                    Toast.makeText(getActivity(), "Error with adding like", Toast.LENGTH_SHORT).show();
                                }
                            });
                        }
                    });
                }
                return true;
            }
        });

        mGoogleMap.addCircle(circleOptions);
        mGoogleMap.addMarker(options);
    }

    private void getLocationPermisssion(){
        if (ContextCompat.checkSelfPermission(getContext(), Manifest.permission.ACCESS_FINE_LOCATION) == PackageManager.PERMISSION_GRANTED) {
            if (ContextCompat.checkSelfPermission(getContext(), Manifest.permission.ACCESS_COARSE_LOCATION) == PackageManager.PERMISSION_GRANTED) {
                mLocationPermissionsGranted = true;
                initMap();
            } else {
                requestPermissions(new String[]{Manifest.permission.ACCESS_COARSE_LOCATION, Manifest.permission.ACCESS_FINE_LOCATION}, MY_PERMISSIONS_REQUEST_LOCATION);
            }
        }
        else {
            requestPermissions(new String[]{Manifest.permission.ACCESS_COARSE_LOCATION, Manifest.permission.ACCESS_FINE_LOCATION}, MY_PERMISSIONS_REQUEST_LOCATION);
        }
    }

    @Override
    public void onRequestPermissionsResult(int requestCode, @NonNull String[] permissions, @NonNull int[] grantResults) {
        mLocationPermissionsGranted = false;

        switch (requestCode){
            case MY_PERMISSIONS_REQUEST_LOCATION: {
                if (grantResults.length>0){
                    for(int i=0; i<grantResults.length;i++){
                        if (grantResults[i] != PackageManager.PERMISSION_GRANTED) {
                            mLocationPermissionsGranted = false;
                            return;
                        }
                    }
                    mLocationPermissionsGranted = true;
                }
            }
        }
    }



    public interface OnFragmentInteractionListener {
        // TODO: Update argument type and name
        void onFragmentInteraction(Uri uri);
    }
}
