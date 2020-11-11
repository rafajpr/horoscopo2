package ws;

import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import java.io.IOException;
import java.net.MalformedURLException;
import model.MessageObject;
import model.Usuario;
import org.json.simple.parser.ParseException;

@WebService(serviceName = "CavaleiroBronzeWS")
public class CavaleiroBronzeWS {
    
    @WebMethod(operationName = "msgDia")
    public String msgDia(@WebParam(name = "signo") String signo) throws IOException, MalformedURLException, ParseException {
        MessageObject msg = new MessageObject();
        return msg.getMessage(signo);
    }
}
