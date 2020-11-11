package ws;

import dao.UsuarioDAO;
import javax.jws.Oneway;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import model.Usuario;

@WebService(serviceName = "UsuarioWS")
public class UsuarioWS {
    UsuarioDAO usuariosDAO = new UsuarioDAO();

    @WebMethod(operationName = "cadastrarUsuario")
    
    public boolean cadastrarUsuario(@WebParam(name = "user") Usuario user) {
        System.out.println("Usuario eh null?: " + user == null);
        boolean success = usuariosDAO.adicionarUsuario(user);
        if(success){
            System.out.println("Cavaleiro cadastrado com sucesso!");
            return success;
        }else{
            System.out.println("Cavaleiro ão cadastrado");
            return success;
        }
    }

    @WebMethod(operationName = "loginUsuario")
    public Usuario loginUsuario(@WebParam(name = "email") String email){
        Usuario user = null;
        user = usuariosDAO.findUsuario(email);
        return user;
    }
}
