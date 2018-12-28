package com.example.domin.movety.api.output;

import com.google.gson.annotations.SerializedName;

import java.util.List;

public class TrainingProposalLikes {
    @SerializedName("trainingProposalId")
    private String TrainingProposalId;

    @SerializedName("athletesBrief")
    private List<AthleteBrief> AthletesBrief;

    public TrainingProposalLikes(){

    }

    public TrainingProposalLikes(String trainingProposalId, List<AthleteBrief> athletesBriefs) {
        TrainingProposalId = trainingProposalId;
        AthletesBrief = athletesBriefs;
    }

    public String getTrainingProposalId() {
        return TrainingProposalId;
    }

    public void setTrainingProposalId(String trainingProposalId) {
        TrainingProposalId = trainingProposalId;
    }

    public List<AthleteBrief> getAthletesBriefs() {
        return AthletesBrief;
    }

    public void setAthletesBriefs(List<AthleteBrief> athletesBrief) {
        AthletesBrief = athletesBrief;
    }

    @Override
    public String toString() {
        return "TrainingProposalLikes{" +
                "TrainingProposalId='" + TrainingProposalId + '\'' +
                ", AthletesBrief=" + AthletesBrief +
                '}';
    }
}
