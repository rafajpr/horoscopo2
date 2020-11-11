package db;

import java.util.ArrayList;
import model.Usuario;

public class Database {
    private static final ArrayList<Usuario> usuarios = new ArrayList<Usuario>();

    public static ArrayList<Usuario> getUsuarios() {
        return usuarios;
    }

}
