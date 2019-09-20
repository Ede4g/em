package com.example.evmoviles;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.widget.ListView;

import static com.example.evmoviles.MainActivity.listaestudiantes;
import adaptador.adaptador;

public class Lista extends AppCompatActivity {

    ListView milista;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_lista);

        milista = findViewById(R.id.lista);
        this.milista.setAdapter(new adaptador(this,
                R.layout.personalizada,listaestudiantes));

    }
}

