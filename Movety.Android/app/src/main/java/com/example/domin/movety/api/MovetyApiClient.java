package com.example.domin.movety.api;

import com.example.domin.movety.api.output.TrainingProposal;

import java.util.List;

import retrofit2.Call;
import retrofit2.http.GET;

public interface MovetyApiClient {
    @GET("/api//trainingproposals")
    Call<List<TrainingProposal>> getTrainingProposals();

    @GET("/api//trainingproposals")
    Call<List<TrainingProposal>> getTrainingProposalsLikes();
}
