package com.example.domin.movety.api.output;

import com.google.gson.annotations.SerializedName;

public class Location {
    @SerializedName("latitude")
    private double Latitude;
    @SerializedName("longitude")
    private double Longitude;

    public Location(){
    }

    public Location(double latitude, double longitude) {
        Latitude = latitude;
        Longitude = longitude;
    }

    public double getLatitude() {
        return Latitude;
    }

    public void setLatitude(double latitude) {
        Latitude = latitude;
    }

    public double getLongitude() {
        return Longitude;
    }

    public void setLongitude(double longitude) {
        Longitude = longitude;
    }

    @Override
    public String toString() {
        return "Location{" +
                "Latitude=" + Latitude +
                ", Longitude=" + Longitude +
                '}';
    }
}
