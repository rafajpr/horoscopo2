package dao;

import java.nio.file.Path;
import java.nio.file.Paths;
import java.util.ArrayList;
import java.util.List;
import model.Usuario;
import java.sql.*;

public class UsuarioDAO {   
    String db;   
    
    public UsuarioDAO(){
        Path path = Paths.get("UsuarioDAO.java");
        path = path.toAbsolutePath();
        path = path.getParent();
        path = path.getParent();
        this.db = "jdbc:sqlite:" + path.toString() + "/Horoscope.db";
    }
    
    public boolean adicionarUsuario(Usuario a){
        String SQL = "INSERT INTO User(name, email, signo, plano) VALUES (?,?,?,?)";
        Connection conn = null;
        try{
            conn = DriverManager.getConnection(db);
            PreparedStatement pstmt = conn.prepareStatement(SQL);
            pstmt.setString(1,a.getNickname());
            pstmt.setString(2,a.getEmail());
            pstmt.setString(3,a.getSigno());
            pstmt.setString(4,a.getPlano());
            pstmt.executeUpdate();
            
        }catch(SQLException e){
            System.out.println(e.getMessage());
            return false;
        }finally{
            try{
                if(conn != null){
                    conn.close();
                }
            }catch(SQLException ex){
                System.out.println(ex.getMessage());
            }
        }
        return true;
    }
    
    public Usuario findUsuario(String email){
        Usuario usuario = null;
        Connection conn = null;
        String SQL = "SELECT * FROM User WHERE User.email = ?";
        try{
            conn = DriverManager.getConnection(db);
            PreparedStatement pstm = conn.prepareStatement(SQL);
            pstm.setString(1, email);
            ResultSet rs = pstm.executeQuery();
            usuario = new Usuario(rs.getString("name"), rs.getString("plano"), rs.getString("email"), rs.getString("signo"));
        }catch(SQLException e){
            System.out.println(e.getMessage());
        }finally{
          try{
                if(conn != null){
                    conn.close();
                }
            }catch(SQLException ex){
                System.out.println(ex.getMessage());
            }  
        }
        return usuario;
    }
}
