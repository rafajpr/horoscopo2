package dao;

import db.Database;
import java.util.ArrayList;
import model.Usuario;

public class UsuarioDAO {   
    
    public UsuarioDAO(){
        
    }
    
    public boolean adicionarUsuario(Usuario a){
        Database.getUsuarios().add(a);
            return true;
    }
    
    public Usuario findUsuario(String email){
        ArrayList<Usuario> usuarios;
        usuarios = Database.getUsuarios();
        for(int i = 0; i < usuarios.size(); i++){
            if(usuarios.get(i).getEmail().equals(email)){
                return usuarios.get(i);
            }
        }
        return null;
    }
}
