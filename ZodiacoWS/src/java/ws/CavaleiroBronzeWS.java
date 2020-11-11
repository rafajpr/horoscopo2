package ws;

import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import java.io.IOException;
import java.net.MalformedURLException;
import java.util.HashMap;
import java.util.Map;
import model.MessageObject;
import model.Usuario;
import org.json.simple.parser.ParseException;

@WebService(serviceName = "CavaleiroBronzeWS")
public class CavaleiroBronzeWS {
    Map<String, String> signoHoroscopo = new HashMap<String, String>() {{
        put("aries", "Optimism and a positive mindset are second to your nature today, says Ganesha. So carry it with you wherever you go. You may tend to be slightly overcautious at work, but that will only protect you. Today seems to be one of those days when you can't stop worrying about your career prospects. But everything shall happen in due course, reminds Ganesha. So sit back and relax with your soul mate.");
        put("touro", "Dark clouds may keep the sunshine from getting through to your window today, says Ganesha. Negative thoughts and apprehensions may cloud your judgement further. You will look to your family and friends to help you get past today.");
        put("gemeos", "Your emotions will cloud your reasoning today, portends Ganesha. You may find refuge in activities related to religion. Money lenders and those in retail business will find their cash registers ringing.");
        put("cancer", "You are honest and straightforward, and today will be no different. It's just that you can be too straight at times, leaving those around you embarrassed. Early in the day, small things may bother you in a big way. You may get involved in big financial transactions. You will get due appreciation for your efforts at work.");
        put("leao", "Resist that urge to pop a pill and call in sick, because no matter how much you wish, escaping from reality is not the way to go, says Ganesha. Yes, there are chances that you shall remain in a pensive mood today with a multitude of thoughts fighting to occupy space inside your head. Work shall be a constant feel-good area as you share valuable moments with your peers, and progress as expected.");
        put("virgem", "Signs are that the day will be bright, rewarding and thoughtful as well. Keep in mind that doomsday is still a long way off. Planetary motions indicate better things to come with each new day.");
        put("libra", "Optimism and a positive mindset are second to your nature today, says Ganesha. So carry it with you wherever you go. You may tend to be slightly overcautious at work, but that will only protect you. Today seems to be one of those days when you can't stop worrying about your career prospects. But everything shall happen in due course, reminds Ganesha. So sit back and relax with your soul mate.");
        put("escorpiao", "You will radiate kindness and care today, says Ganesha. Quarantine yourself from worries at work. Open your heart to loved ones today.");
        put("sagitario", "All prim and proper, today you dress up to grab eyeballs. You are surrounded by glitteratti when you attend a social function today. Your effective communication skills will be like icing on the cake and work wonders.");
        put("capricornio", "The profundity of relationships will intrigue you, luring you to delve deeper into them, says Ganesha. Your strong persuasive power will help clear many misunderstandings that may have cut a rift in your relationship with your sweetheart in the past.");
        put("aquario", "When the going gets tough, the tough gets going! You will find your way through the storm, that too with a smile on your face. While you will be trying to manage your responsibilities on one hand, you will be pleasing everyone around with your wit and humour on the other.");
        put("peixes", "A day where you will be on your toes, you will find yourself constantly on the move, keeping up with the numerous demands of the workplace in your quest to control the workings of your department or business.");
    }};
    
    
    @WebMethod(operationName = "msgDia")
    public String msgDia(@WebParam(name = "signo") String signo) throws IOException, MalformedURLException, ParseException {
        signo = signo.trim();
        signo = signo.toLowerCase();
        return signoHoroscopo.get(signo);
    }
}
