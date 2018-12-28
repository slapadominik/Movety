package com.example.domin.movety;

import android.content.Context;
import android.content.Intent;
import android.os.Bundle;
import android.support.annotation.NonNull;
import android.support.v7.widget.RecyclerView;
import android.util.Log;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;
import android.widget.LinearLayout;
import android.widget.TextView;
import com.example.domin.movety.api.output.TrainingProposal;

import java.util.List;

public class RecyclerViewAdapter extends RecyclerView.Adapter<RecyclerViewAdapter.MyViewHolder> {

    public static final String TRAINING_ID = "TRAINING_ID";
    public static final String TITLE_TRAINING = "TITLE_TRAINING";
    public static final String TRAINING_AUTHOR = "TRAINING_AUTHOR";
    public static final String TRAINING_DATEFROM = "TITLE_DATEFROM";
    public static final String TRAINING_DATETO = "TITLE_DATETO";
    public static final String TRAINING_DESCRIPTION = "TITLE_DESCRIPTION";

    Context context;
    private List<com.example.domin.movety.api.output.TrainingProposal> trainingProposals;

    public RecyclerViewAdapter(Context context, List<TrainingProposal> trainingProposals){
        this.context = context;
        this.trainingProposals = trainingProposals;
    }


    @NonNull
    @Override
    public RecyclerViewAdapter.MyViewHolder onCreateViewHolder(@NonNull ViewGroup parent, int i) {
        View v;
        v = LayoutInflater.from(context).inflate(R.layout.item_training, parent, false);
        final MyViewHolder vHolder  = new MyViewHolder(v);

        vHolder.item_training.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent = new Intent(context, TrainingProposalDetails.class);
                Bundle extras = new Bundle();
                String id = trainingProposals.get(vHolder.getAdapterPosition()).getId();
                String trainingTitle = trainingProposals.get(vHolder.getAdapterPosition()).getTitle();
                String trainingAuthor = trainingProposals.get(vHolder.getAdapterPosition()).getAuthor();
                String trainingDatefrom = trainingProposals.get(vHolder.getAdapterPosition()).getDatetimeFrom();
                String trainingDateto = trainingProposals.get(vHolder.getAdapterPosition()).getDatetimeTo();
                String trainingDescription = trainingProposals.get(vHolder.getAdapterPosition()).getDescription();
                Log.i("MOVETYAPI", "Item clicked: "+trainingProposals.get(vHolder.getAdapterPosition()).toString());
                extras.putString(TRAINING_ID, id);
                extras.putString(TITLE_TRAINING, trainingTitle);
                extras.putString(TRAINING_AUTHOR, trainingAuthor);
                extras.putString(TRAINING_DATEFROM, trainingDatefrom);
                extras.putString(TRAINING_DATETO, trainingDateto);
                extras.putString(TRAINING_DESCRIPTION, trainingDescription);
                intent.putExtras(extras);

                context.startActivity(intent);
            }
        });
        return vHolder;
    }

    public void onBindViewHolder(MyViewHolder holder, int position){
        holder.tv_name.setText(trainingProposals.get(position).getTitle());
        holder.tv_date.setText(trainingProposals.get(position).getDatetimeFrom());
        holder.img.setImageResource(R.mipmap.bike);
        holder.tv_participants.setText(trainingProposals.get(position).getMaxParticipants());
        holder.tv_author.setText(trainingProposals.get(position).getAuthor());
    }

    @Override
    public int getItemCount() {
        return trainingProposals.size();
    }

    public static class MyViewHolder extends RecyclerView.ViewHolder {

        private TextView tv_name;
        private TextView tv_date;
        private TextView tv_author;
        private TextView tv_participants;
        private ImageView img;
        private LinearLayout item_training;

        public MyViewHolder(@NonNull View itemView) {
            super(itemView);
            item_training = itemView.findViewById(R.id.item_training_id);
            tv_name = itemView.findViewById(R.id.training_name);
            tv_date = itemView.findViewById(R.id.training_date);
            tv_author = itemView.findViewById(R.id.training_author);
            tv_participants = itemView.findViewById(R.id.training_participants);
            img = itemView.findViewById(R.id.training_image);
        }
    }
}
