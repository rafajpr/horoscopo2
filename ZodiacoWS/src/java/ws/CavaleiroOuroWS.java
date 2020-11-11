package ws;

import java.util.HashMap;
import java.util.Map;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;

@WebService(serviceName = "CavaleiroOuroWS")
public class CavaleiroOuroWS extends CavaleiroBronzeWS{
    Map<String, String> signoCavaleiro = new HashMap<String, String>() {{
        put("aries", "Mu");
        put("touro", "Aldebaran");
        put("gemeos", "Saga");
        put("cancer", "Mascara da Morte");
        put("leao", "Aiolia");
        put("virgem", "Shaka");
        put("libra", "Dohko");
        put("escorpiao", "Milo");
        put("sagitario", "Aiolos");
        put("capricornio", "Shura");
        put("aquario", "Câmus");
        put("peixes", "Afrodite");
    }};


    @WebMethod(operationName = "qualCavaleiro")
    public String qualCavaleiro(@WebParam(name = "signo") String signo) {
        signo = signo.trim();
        signo = signo.toLowerCase();
        return signoCavaleiro.get(signo);
    }
}
