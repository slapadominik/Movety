package com.example.domin.movety.api.output;

import com.google.gson.annotations.SerializedName;

public class TrainingProposalLike {
    @SerializedName("userId")
    private String userId;
    @SerializedName("trainingProposalId")
    private String trainingProposalId;

    public TrainingProposalLike(){

    }

    public TrainingProposalLike(String userId, String trainingProposalId) {
        this.userId = userId;
        this.trainingProposalId = trainingProposalId;
    }

    public String getUserId() {
        return userId;
    }

    public void setUserId(String userId) {
        this.userId = userId;
    }

    public String getTrainingProposalId() {
        return trainingProposalId;
    }

    public void setTrainingProposalId(String trainingProposalId) {
        this.trainingProposalId = trainingProposalId;
    }

    @Override
    public String toString() {
        return "TrainingProposalLike{" +
                "userId='" + userId + '\'' +
                ", trainingProposalId='" + trainingProposalId + '\'' +
                '}';
    }
}
