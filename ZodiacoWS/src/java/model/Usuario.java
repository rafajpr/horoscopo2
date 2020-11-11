package model;

import java.io.IOException;
import java.io.Serializable;
import java.net.MalformedURLException;
import org.json.simple.parser.ParseException;


public class Usuario implements Serializable{
    private String nickname;
    private String email;
    private String plano;
    private String signo;

    public Usuario(String nickname, String plano,String email, String signo) {
        this.nickname = nickname;
        this.plano = plano;
        this.signo = signo;
        this.email = email;
    }

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }
    
    public String getSigno() {
        return signo;
    }

    public void setSigno(String signo) {
        this.signo = signo;
    }

    public String getNickname() {
        return nickname;
    }

    public void setNickname(String nickname) {
        this.nickname = nickname;
    }

    public String getPlano() {
        return plano;
    }

    public void setPlano(String plano) {
        this.plano = plano;
    }
 
    public String getDailyHoroscope() throws IOException, MalformedURLException, ParseException{
        MessageObject msg = new MessageObject();
        return msg.getMessage(this.signo);
    }

}
