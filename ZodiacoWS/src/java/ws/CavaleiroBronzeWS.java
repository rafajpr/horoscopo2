package ws;

import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import java.io.IOException;
import java.net.MalformedURLException;
import model.Usuario;
import org.json.simple.parser.ParseException;

@WebService(serviceName = "CavaleiroBronzeWS")
public class CavaleiroBronzeWS {
    
    @WebMethod(operationName = "msgDia")
    public String msgDia(@WebParam(name = "user") Usuario user) throws IOException, MalformedURLException, ParseException {
        String msg = user.getDailyHoroscope();
        return msg;
    }
}
