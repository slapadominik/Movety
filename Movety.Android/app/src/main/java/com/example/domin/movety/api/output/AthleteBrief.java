package com.example.domin.movety.api.output;

import com.google.gson.annotations.SerializedName;

public class AthleteBrief {
    @SerializedName("userId")
    private String UserId;

    @SerializedName("firstName")
    private String FirstName;

    @SerializedName("lastName")
    private String LastName;

    @SerializedName("age")
    private int Age;

    public AthleteBrief(){

    }

    public AthleteBrief(String userId, String firstName, String lastName, int age) {
        UserId = userId;
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }

    public String getUserId() {
        return UserId;
    }

    public void setUserId(String userId) {
        UserId = userId;
    }

    public String getFirstName() {
        return FirstName;
    }

    public void setFirstName(String firstName) {
        FirstName = firstName;
    }

    public String getLastName() {
        return LastName;
    }

    public void setLastName(String lastName) {
        LastName = lastName;
    }

    public int getAge() {
        return Age;
    }

    public void setAge(int age) {
        Age = age;
    }

    @Override
    public String toString() {
        return "AthleteBrief{" +
                "UserId='" + UserId + '\'' +
                ", FirstName='" + FirstName + '\'' +
                ", LastName='" + LastName + '\'' +
                ", Age=" + Age +
                '}';
    }
}
