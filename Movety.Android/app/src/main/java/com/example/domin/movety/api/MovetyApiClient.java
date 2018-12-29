package com.example.domin.movety.api;

import com.example.domin.movety.api.output.TrainingProposal;
import com.example.domin.movety.api.output.TrainingProposalLikes;
import com.example.domin.movety.api.output.TrainingProposalsLikedByUser;

import java.util.List;

import retrofit2.Call;
import retrofit2.http.GET;
import retrofit2.http.Path;

public interface MovetyApiClient {
    @GET("/api/trainingproposals")
    Call<List<TrainingProposal>> getTrainingProposals();

    @GET("/api/trainingproposalslikes/{id}")
    Call<TrainingProposalLikes> getLikesByTrainingProposalId(@Path("id") String id);

    @GET("/api/users/{id}/likes")
    Call<TrainingProposalsLikedByUser> getLikedTrainingProposalsForUser(@Path("id") String userId);
}
