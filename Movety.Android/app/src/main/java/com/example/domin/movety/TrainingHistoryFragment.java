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
import com.example.domin.movety.api.output.AthleteBrief;
import com.example.domin.movety.api.output.Location;
import com.example.domin.movety.api.output.TrainingProposal;
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


public class TrainingHistoryFragment extends Fragment {

    private View view;
    private RecyclerView myRecyclerView;
    private List<TrainingProposal> trainingProposals;

    @Override
    public View onCreateView(@NonNull LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        view = inflater.inflate(R.layout.fragment_training_history, container, false);
        myRecyclerView = view.findViewById(R.id.history_recyclerview);
        RecyclerViewAdapter recyclerViewAdapter = new RecyclerViewAdapter(getContext(), trainingProposals);
        myRecyclerView.setLayoutManager(new LinearLayoutManager(getActivity()));
        myRecyclerView.setAdapter(recyclerViewAdapter);
        return view;
    }

    @Override
    public void onCreate(@Nullable Bundle savedInstace){
        super.onCreate(savedInstace);
        trainingProposals = new ArrayList<>();
    }

}
