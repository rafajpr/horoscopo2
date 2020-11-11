package dao;

import db.Database;
import java.util.ArrayList;
import model.Usuario;

public class UsuarioDAO {   
    
    private Database database;
    
    public UsuarioDAO(){
        database = new Database();
    }
    
    public boolean adicionarUsuario(Usuario a){
        database.getUsuarios().add(a);
        System.out.println("Database: "+database.getUsuarios());
        return true;
    }
    
    public Usuario findUsuario(String email){
        ArrayList<Usuario> usuarios;
        usuarios = database.getUsuarios();
        System.out.println("usuarios: "+usuarios);
        for(int i = 0; i < usuarios.size(); i++){
            
            System.out.println("Email:"+usuarios.get(i).getEmail());
            System.out.println("Email2:"+email);
            if(usuarios.get(i).getEmail().equals(email)){
                return usuarios.get(i);
            }
        }
        return null;
    }
}
