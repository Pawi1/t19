package com.example.zadanie;

import android.os.Bundle;
import android.widget.EditText;
import android.widget.Toast;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

public class Dodawanie extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_dodawanie);
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });
        findViewById(R.id.oblicz).setOnClickListener(v -> {
            try {
                EditText licz1 = findViewById(R.id.liczba1);
                EditText licz2 = findViewById(R.id.liczba2);
                int l1 = Integer.parseInt(licz1.getText().toString());
                int l2 = Integer.parseInt(licz2.getText().toString());
                Toast.makeText(this, String.format("%d+%d= %d",l1,l2,l1+l2), Toast.LENGTH_SHORT).show();
            }
            catch(Exception e) {
                Toast.makeText(this, "Niepoprawne dane", Toast.LENGTH_SHORT).show();
            }
        });
    }
}