package com.example.domin.movety.api;

import com.example.domin.movety.api.output.TrainingProposal;
import com.example.domin.movety.api.output.TrainingProposalLike;
import com.example.domin.movety.api.output.TrainingProposalLikes;
import com.example.domin.movety.api.output.TrainingProposalsLikedByUser;

import java.util.List;

import retrofit2.Call;
import retrofit2.http.Body;
import retrofit2.http.Field;
import retrofit2.http.GET;
import retrofit2.http.POST;
import retrofit2.http.Path;

public interface MovetyApiClient {
    @GET("/api/trainingproposals/{id}/likes")
    Call<TrainingProposalLikes> getLikesByTrainingProposalId(@Path("id") String id);

    @GET("/api/users/{id}/likes")
    Call<TrainingProposalsLikedByUser> getLikedTrainingProposalsForUser(@Path("id") String userId);

    @GET("/api/users/{id}/trainingproposals")
    Call<List<TrainingProposal>> getNewTrainingProposalsForUser(@Path("id") String userId);

    @POST("/api/users/likes")
    Call<TrainingProposalLike> addTrainingProposalLike(@Body TrainingProposalLike like);
}
