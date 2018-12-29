package com.example.domin.movety.api.output;

import com.google.gson.annotations.SerializedName;

public class TrainingProposal {
    @SerializedName("id")
    private String Id;

    @SerializedName("title")
    private String Title;
    @SerializedName("author")
    private String Author;
    @SerializedName("location")
    private Location Location;

    @SerializedName("datetimeFrom")
    private String DatetimeFrom;
    @SerializedName("datetimeTo")
    private String DatetimeTo;
    @SerializedName("description")
    private String Description;
    @SerializedName("maxParticipants")
    private String MaxParticipants;

    public TrainingProposal(){
    }

    public TrainingProposal(String id, String title, String author, com.example.domin.movety.api.output.Location location, String datetimeFrom, String datetimeTo, String description, String maxParticipants) {
        Id = id;
        Title = title;
        Author = author;
        Location = location;
        DatetimeFrom = datetimeFrom;
        DatetimeTo = datetimeTo;
        Description = description;
        MaxParticipants = maxParticipants;
    }

    public com.example.domin.movety.api.output.Location getLocation() {
        return Location;
    }

    public void setLocation(com.example.domin.movety.api.output.Location location) {
        Location = location;
    }

    public String getTitle() {
        return Title;
    }

    public void setTitle(String title) {
        Title = title;
    }

    public String getAuthor() {
        return Author;
    }

    public void setAuthor(String author) {
        Author = author;
    }

    public String getId() {
        return Id;
    }

    public void setId(String id) {
        Id = id;
    }

    public String getDatetimeFrom() {
        return DatetimeFrom;
    }

    public void setDatetimeFrom(String datetimeFrom) {
        DatetimeFrom = datetimeFrom;
    }

    public String getDatetimeTo() {
        return DatetimeTo;
    }

    public void setDatetimeTo(String datetimeTo) {
        DatetimeTo = datetimeTo;
    }

    public String getDescription() {
        return Description;
    }

    public void setDescription(String description) {
        Description = description;
    }

    public String getMaxParticipants() {
        return MaxParticipants;
    }

    public void setMaxParticipants(String maxParticipants) {
        MaxParticipants = maxParticipants;
    }

    @Override
    public String toString() {
        return "TrainingProposal{" +
                "Id='" + Id + '\'' +
                ", Title='" + Title + '\'' +
                ", Author='" + Author + '\'' +
                ", Location=" + Location +
                ", DatetimeFrom='" + DatetimeFrom + '\'' +
                ", DatetimeTo='" + DatetimeTo + '\'' +
                ", Description='" + Description + '\'' +
                ", MaxParticipants='" + MaxParticipants + '\'' +
                '}';
    }
}
