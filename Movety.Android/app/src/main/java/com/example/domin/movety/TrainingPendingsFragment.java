package com.example.domin.movety;

import android.os.Bundle;
import android.support.annotation.NonNull;
import android.support.annotation.Nullable;
import android.support.v4.app.Fragment;
import android.support.v7.widget.LinearLayoutManager;
import android.support.v7.widget.RecyclerView;
import android.util.Log;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Toast;

import com.example.domin.movety.api.MovetyApiClient;
import com.example.domin.movety.api.output.TrainingProposal;
import com.example.domin.movety.api.output.TrainingProposalsLikedByUser;
import com.example.domin.movety.security.Authentication;
import com.google.gson.Gson;
import com.google.gson.GsonBuilder;

import java.text.DateFormat;
import java.util.ArrayList;
import java.util.List;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;
import retrofit2.Retrofit;
import retrofit2.converter.gson.GsonConverterFactory;


public class TrainingPendingsFragment extends Fragment {

    private View view;
    private RecyclerView myRecyclerView;
    private List<com.example.domin.movety.api.output.TrainingProposal> trainingProposals;

    @Override
    public View onCreateView(@NonNull LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        view = inflater.inflate(R.layout.fragment_training_pendings, container, false);
        myRecyclerView = view.findViewById(R.id.pendings_recyclerview);
        RecyclerViewAdapter recyclerViewAdapter = new RecyclerViewAdapter(getContext(), trainingProposals);
        myRecyclerView.setLayoutManager(new LinearLayoutManager(getActivity()));
        myRecyclerView.setAdapter(recyclerViewAdapter);
        return view;
    }


    @Override
    public void onCreate(@Nullable Bundle savedInstace){
        super.onCreate(savedInstace);

        trainingProposals = new ArrayList<>();
        Gson gson = new GsonBuilder().serializeNulls().setDateFormat(DateFormat.LONG).create();

        Retrofit.Builder builder = new Retrofit.Builder()
                .baseUrl("https://movetyapi.azurewebsites.net/")
                .addConverterFactory(GsonConverterFactory.create(gson));
        Retrofit retrofit = builder.build();

        MovetyApiClient client = retrofit.create(MovetyApiClient.class);
        Call<TrainingProposalsLikedByUser> call = client.getLikedTrainingProposalsForUser(Authentication.CLINET_ID);

        call.enqueue(new Callback<TrainingProposalsLikedByUser>() {
            @Override
            public void onResponse(Call<TrainingProposalsLikedByUser> call, Response<TrainingProposalsLikedByUser> response) {
                Log.i("MOVETYAPI", "size: "+response.body());
                if (response.body() != null){
                    trainingProposals = response.body().getTrainingProposalList();
                    for (int i=0; i<trainingProposals.size(); i++){
                        Log.i("MOVETYAPI", trainingProposals.get(i).toString());
                    }
                    RecyclerViewAdapter recyclerViewAdapter = new RecyclerViewAdapter(getContext(), trainingProposals);
                    myRecyclerView.setLayoutManager(new LinearLayoutManager(getActivity()));
                    myRecyclerView.setAdapter(recyclerViewAdapter);
                }
            }

            @Override
            public void onFailure(Call<TrainingProposalsLikedByUser> call, Throwable t) {
                Toast.makeText(getContext(), "Error: errorrr", Toast.LENGTH_SHORT).show();
            }
        });
    }
}
