package com.example.domin.movety;

import android.os.Bundle;
import android.support.design.widget.CollapsingToolbarLayout;
import android.support.v7.app.AppCompatActivity;
import android.support.v7.widget.Toolbar;
import android.util.Log;
import android.widget.TextView;

public class TrainingProposalDetails extends AppCompatActivity {

    private TextView tvTitle;
    private TextView tvAuthor;
    private TextView tvDatefrom;
    private TextView tvDateto;
    private TextView tvDescription;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_training_proposal_details);

        tvTitle = findViewById(R.id.training_details_title);
        tvAuthor = findViewById(R.id.training_details_author);
        tvDatefrom = findViewById(R.id.training_details_datefrom);
        tvDateto = findViewById(R.id.training_details_dateto);
        tvDescription = findViewById(R.id.training_details_description);

        CollapsingToolbarLayout toolbarLayout = findViewById(R.id.toolbar_layout);

        Toolbar toolbar = (Toolbar) findViewById(R.id.toolbar);

        Bundle extras = getIntent().getExtras();
        Log.i("MOVETYAPI", "onCreate: "+extras.getString(RecyclerViewAdapter.TITLE_TRAINING));
        String title = extras.getString(RecyclerViewAdapter.TITLE_TRAINING);
        String author= extras.getString(RecyclerViewAdapter.TRAINING_AUTHOR);
        String datefrom = extras.getString(RecyclerViewAdapter.TRAINING_DATEFROM);
        String dateto = extras.getString(RecyclerViewAdapter.TRAINING_DATETO);
        String desc = extras.getString(RecyclerViewAdapter.TRAINING_DESCRIPTION);
        tvTitle.setText(title);
        tvAuthor.setText(author);
        tvDatefrom.setText(datefrom);
        tvDateto.setText(dateto);
        tvDescription.setText(desc);

        setSupportActionBar(toolbar);
        if (getSupportActionBar()!=null){
            getSupportActionBar().setDisplayHomeAsUpEnabled(true);
        }
    }

    @Override
    public boolean onSupportNavigateUp() {
        onBackPressed();
        return true;
    }
}
