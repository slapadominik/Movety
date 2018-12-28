package com.example.domin.movety;

public class TrainingProposal {

    private String Name;
    private String Author;
    private String Participants;
    private String Date;
    private int Photo;

    public TrainingProposal(){

    }

    public TrainingProposal(String name, String date, int photo, String author, String participants){
        Name = name;
        Date = date;
        Photo = photo;
        Author = author;
        Participants = participants;
    }

    public String getName() {
        return Name;
    }

    public String getDate() {
        return Date;
    }

    public int getPhoto() {
        return Photo;
    }

    public void setName(String name) {
        Name = name;
    }

    public String getAuthor() {
        return Author;
    }

    public void setAuthor(String author) {
        Author = author;
    }

    public String getParticipants() {
        return Participants;
    }

    public void setParticipants(String participants) {
        Participants = participants;
    }

    public void setDate(String date) {
        Date = date;
    }

    public void setPhoto(int photo) {
        Photo = photo;
    }
}
