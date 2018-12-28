package com.example.domin.movety;

import android.support.annotation.ColorRes;
import android.support.annotation.NonNull;
import android.support.design.widget.BottomNavigationView;
import android.support.v4.app.Fragment;
import android.support.v4.app.FragmentActivity;
import android.os.Bundle;
import android.support.v4.app.FragmentTransaction;
import android.support.v4.content.ContextCompat;
import android.util.Log;
import android.view.MenuItem;


public class MainActivity extends FragmentActivity{

    private BottomNavigationView bottomNavBar;
    private int mSelectedItem;
    private static final String SELECTED_ITEM = "arg_selected_item";

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        bottomNavBar = findViewById(R.id.bottomNavBar);

        bottomNavBar.setOnNavigationItemSelectedListener(new BottomNavigationView.OnNavigationItemSelectedListener() {
            @Override
            public boolean onNavigationItemSelected(@NonNull MenuItem item) {
                selectFragment(item);
                return true;
            }
        });
        ConfigureBottomNavbarItemSelection(savedInstanceState);
        bottomNavBar.setSelectedItemId(R.id.menu_workout);
    }

    @Override
    protected void onSaveInstanceState(Bundle outState) {
        outState.putInt(SELECTED_ITEM, mSelectedItem);
        super.onSaveInstanceState(outState);
    }

    @Override
    public void onBackPressed() {
        MenuItem homeItem = bottomNavBar.getMenu().getItem(0);
        if (mSelectedItem != homeItem.getItemId()) {
            bottomNavBar.setSelectedItemId(R.id.menu_workout);
        } else {
            super.onBackPressed();
        }
    }

    private void selectFragment(MenuItem item) {
        Fragment frag = null;

        switch (item.getItemId()) {
            case R.id.menu_workout:
                frag = TrainingsFragment.newInstance(getColorFromRes(R.color.colorWhite));
                break;
            case R.id.menu_chat:
                frag = MenuFragment.newInstance(getString(R.string.text_chat),
                        getColorFromRes(R.color.color_home));
                break;
            case R.id.menu_map:
                frag = MapsFragment.newInstance();

                break;
            case R.id.menu_profile:
                frag = ProfileFragment.newInstance();
                break;
        }

        // update selected item
        mSelectedItem = item.getItemId();
        Log.i("MYTAG", "m selected item "+mSelectedItem);


        // uncheck the other items.
        for (int i = 0; i< bottomNavBar.getMenu().size(); i++) {
            Log.i("MYTAG", "m selected item "+bottomNavBar.getMenu().getItem(i).getTitle()+" "+bottomNavBar.getMenu().getItem(i).getItemId());
            MenuItem menuItem = bottomNavBar.getMenu().getItem(i);
            menuItem.setChecked(menuItem.getItemId() == item.getItemId());
        }

        if (frag != null) {
            FragmentTransaction ft = getSupportFragmentManager().beginTransaction();
            ft.replace(R.id.container, frag, frag.getTag());
            ft.commit();
        }
    }

    private void ConfigureBottomNavbarItemSelection(Bundle savedInstanceState){
        MenuItem selectedItem;
        if (savedInstanceState != null) {
            mSelectedItem = savedInstanceState.getInt(SELECTED_ITEM, 0);
            selectedItem = bottomNavBar.getMenu().findItem(mSelectedItem);
        } else {
            selectedItem = bottomNavBar.getMenu().getItem(0);
        }
        selectFragment(selectedItem);
    }

    private int getColorFromRes(@ColorRes int resId) {
        return ContextCompat.getColor(this, resId);
    }
}
