package com.example.domin.movety.api.output;

import com.google.gson.annotations.SerializedName;

import java.util.List;

public class TrainingProposalsLikedByUser {
    @SerializedName("userId")
    private String userId;

    @SerializedName("trainingProposals")
    private List<TrainingProposal> trainingProposalList;

    public TrainingProposalsLikedByUser(){

    }

    public TrainingProposalsLikedByUser(String userId, List<TrainingProposal> trainingProposalList) {
        this.userId = userId;
        this.trainingProposalList = trainingProposalList;
    }

    public String getUserId() {
        return userId;
    }

    public void setUserId(String userId) {
        this.userId = userId;
    }

    public List<TrainingProposal> getTrainingProposalList() {
        return trainingProposalList;
    }

    public void setTrainingProposalList(List<TrainingProposal> trainingProposalList) {
        this.trainingProposalList = trainingProposalList;
    }

    @Override
    public String toString() {
        return "TrainingProposalsLikedByUser{" +
                "userId='" + userId + '\'' +
                ", trainingProposalList=" + trainingProposalList +
                '}';
    }
}
