package ws;

import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import dao.UsuarioDAO;
import model.Usuario;

@WebService(serviceName = "CavaleiroBronzeWS")
public class CavaleiroBronzeWS {
    
    @WebMethod(operationName = "msgDia")
    public String msgDia(@WebParam(name = "user") Usuario user) {
        String msg = user.getDailyHoroscope();
        return msg;
    }
}
