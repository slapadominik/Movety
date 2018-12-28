package com.example.domin.movety;


import android.os.Bundle;
import android.support.annotation.Nullable;
import android.support.design.widget.TabLayout;
import android.support.v4.app.Fragment;
import android.support.v4.view.ViewPager;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.TextView;


/**
 * A simple {@link Fragment} subclass.
 */
public class TrainingsFragment extends Fragment {


    private static final String ARG_COLOR = "arg_color";

    private View mContent;
    private int mColor;
    private TabLayout tabLayout;
    private ViewPager viewPager;
    private ViewPagerAdapter adapter;

    public TrainingsFragment() {
        // Required empty public constructor
    }

    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setRetainInstance(true);
    }


    public static Fragment newInstance(int color) {
         Fragment fragment = new TrainingsFragment();
        Bundle args = new Bundle();
        args.putInt(ARG_COLOR, color);
        fragment.setArguments(args);
        return fragment;
    }

    @Override
    public void onViewCreated(View view, @Nullable Bundle savedInstanceState) {
        super.onViewCreated(view, savedInstanceState);

        // retrieve text rom bundle or savedInstanceState
        if (savedInstanceState == null) {
            Bundle args = getArguments();
            mColor = args.getInt(ARG_COLOR);
        } else {
            mColor = savedInstanceState.getInt(ARG_COLOR);
        }

        mContent = view.findViewById(R.id.fragment_training_content);
        mContent.setBackgroundColor(mColor);
    }

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        // Inflate the layout for this fragment
        View view = inflater.inflate(R.layout.fragment_trainings, container, false);
        viewPager = view.findViewById(R.id.trainings_viewpager);

        adapter = new ViewPagerAdapter(getChildFragmentManager());
        adapter.AddFragment(new TrainingPendingsFragment(), "Oczekujące");
        adapter.AddFragment(new TrainingHistoryFragment(), "Własne");
        viewPager.setAdapter(adapter);

        tabLayout = view.findViewById(R.id.trainings_tablayout);
        tabLayout.setupWithViewPager(viewPager);
        return view;
    }

    @Override
    public void onSaveInstanceState(Bundle outState) {
        outState.putInt(ARG_COLOR, mColor);
        super.onSaveInstanceState(outState);
    }

}
