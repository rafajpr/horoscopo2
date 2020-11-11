package db;

import java.util.ArrayList;
import model.Usuario;

public class Database {
    private ArrayList<Usuario> usuarios;

    public ArrayList<Usuario> getUsuarios() {
        if (usuarios == null)
            usuarios = new ArrayList<Usuario>();
        return usuarios;
    }
}
