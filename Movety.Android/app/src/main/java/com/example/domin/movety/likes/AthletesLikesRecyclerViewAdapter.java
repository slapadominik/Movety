package com.example.domin.movety.likes;

import android.annotation.SuppressLint;
import android.content.Context;
import android.support.annotation.NonNull;
import android.support.v7.widget.RecyclerView;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.TextView;
import com.example.domin.movety.R;
import com.example.domin.movety.api.output.AthleteBrief;

import java.util.List;

public class AthletesLikesRecyclerViewAdapter extends RecyclerView.Adapter<AthletesLikesRecyclerViewAdapter.AthleteViewHolder> {

    Context context;
    private List<AthleteBrief> athleteBriefs;

    public AthletesLikesRecyclerViewAdapter(Context context, List<AthleteBrief> athleteBriefs){
        this.context = context;
        this.athleteBriefs = athleteBriefs;
    }

    @SuppressLint("SetTextI18n")
    @Override
    public void onBindViewHolder(AthletesLikesRecyclerViewAdapter.AthleteViewHolder holder, int position){
        holder.tv_age.setText(Integer.toString(athleteBriefs.get(position).getAge()));
        holder.tv_firstName.setText(athleteBriefs.get(position).getFirstName());
        holder.tv_lastName.setText(athleteBriefs.get(position).getLastName());
    }

    @NonNull
    @Override
    public AthleteViewHolder onCreateViewHolder(@NonNull ViewGroup viewGroup, int i) {
        View v;
        v = LayoutInflater.from(context).inflate(R.layout.item_athletebrief, viewGroup, false);
        final AthletesLikesRecyclerViewAdapter.AthleteViewHolder vHolder  = new AthletesLikesRecyclerViewAdapter.AthleteViewHolder(v);
        return vHolder;
    }


    @Override
    public int getItemCount() {
        return athleteBriefs.size();
    }

    public static class AthleteViewHolder extends RecyclerView.ViewHolder {

        private TextView tv_firstName;
        private TextView tv_lastName;
        private TextView tv_age;


        public AthleteViewHolder(@NonNull View itemView) {
            super(itemView);
            tv_firstName = itemView.findViewById(R.id.item_athletebrief_firstname);
            tv_lastName = itemView.findViewById(R.id.item_athletebrief_lastname);
            tv_age = itemView.findViewById(R.id.item_athletebrief_age);
        }
    }

}
