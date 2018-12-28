package com.example.domin.movety;

import android.os.Bundle;
import android.support.design.widget.CollapsingToolbarLayout;
import android.support.v7.app.AppCompatActivity;
import android.support.v7.widget.LinearLayoutManager;
import android.support.v7.widget.RecyclerView;
import android.support.v7.widget.Toolbar;
import android.util.Log;
import android.widget.TextView;
import android.widget.Toast;

import com.example.domin.movety.api.MovetyApiClient;
import com.example.domin.movety.api.output.AthleteBrief;
import com.example.domin.movety.api.output.TrainingProposal;
import com.example.domin.movety.api.output.TrainingProposalLikes;
import com.example.domin.movety.likes.AthletesLikesRecyclerViewAdapter;
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

public class TrainingProposalDetails extends AppCompatActivity {

    private TextView tvTitle;
    private TextView tvAuthor;
    private TextView tvDatefrom;
    private TextView tvDateto;
    private TextView tvDescription;
    private String TrainingProposalId;
    private List<AthleteBrief> athleteBriefs;
    private RecyclerView myRecyclerView;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        athleteBriefs = new ArrayList<>();
        setContentView(R.layout.activity_training_proposal_details);

        tvTitle = findViewById(R.id.training_details_title);
        tvAuthor = findViewById(R.id.training_details_author);
        tvDatefrom = findViewById(R.id.training_details_datefrom);
        tvDateto = findViewById(R.id.training_details_dateto);
        tvDescription = findViewById(R.id.training_details_description);
        myRecyclerView = findViewById(R.id.athletesbrief_recyclerview);

        CollapsingToolbarLayout toolbarLayout = findViewById(R.id.toolbar_layout);

        Toolbar toolbar = (Toolbar) findViewById(R.id.toolbar);

        Bundle extras = getIntent().getExtras();
        Log.i("MOVETYAPI", "onCreate: "+extras.getString(RecyclerViewAdapter.TRAINING_ID));
        TrainingProposalId = extras.getString(RecyclerViewAdapter.TRAINING_ID);
        String title = extras.getString(RecyclerViewAdapter.TITLE_TRAINING);
        String author= extras.getString(RecyclerViewAdapter.TRAINING_AUTHOR);
        String datefrom = extras.getString(RecyclerViewAdapter.TRAINING_DATEFROM);
        String dateto = extras.getString(RecyclerViewAdapter.TRAINING_DATETO);
        String desc = extras.getString(RecyclerViewAdapter.TRAINING_DESCRIPTION);

        tvTitle.setText(title);
        tvAuthor.setText(author);
        tvDatefrom.setText(datefrom);
        tvDateto.setText(dateto);
        tvDescription.setText(desc);

        setSupportActionBar(toolbar);
        if (getSupportActionBar()!=null){
            getSupportActionBar().setDisplayHomeAsUpEnabled(true);
        }

        if (TrainingProposalId != null){
            Gson gson = new GsonBuilder().serializeNulls().setDateFormat(DateFormat.LONG).create();

            Retrofit.Builder builder = new Retrofit.Builder()
                    .baseUrl("https://movetyapi.azurewebsites.net/")
                    .addConverterFactory(GsonConverterFactory.create(gson));
            Retrofit retrofit = builder.build();

            MovetyApiClient client = retrofit.create(MovetyApiClient.class);
            Call<TrainingProposalLikes> call = client.getLikesByTrainingProposalId(TrainingProposalId);
            call.enqueue(new Callback<TrainingProposalLikes>() {
                @Override
                public void onResponse(Call<TrainingProposalLikes> call, Response<TrainingProposalLikes> response) {
                    Log.i("MOVETYAPI", "size: "+response.body());
                    if (response.body() != null){
                        athleteBriefs = response.body().getAthletesBriefs();
                        AthletesLikesRecyclerViewAdapter recyclerViewAdapter = new AthletesLikesRecyclerViewAdapter(getApplicationContext(), athleteBriefs);
                        myRecyclerView.setLayoutManager(new LinearLayoutManager(getApplicationContext()));
                        myRecyclerView.setAdapter(recyclerViewAdapter);
                    }
                }

                @Override
                public void onFailure(Call<TrainingProposalLikes> call, Throwable t) {
                    Toast.makeText(getApplicationContext(), "Error athletes brief", Toast.LENGTH_SHORT).show();
                }
            });
        }

    }

    @Override
    public boolean onSupportNavigateUp() {
        onBackPressed();
        return true;
    }
}
