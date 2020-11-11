
package model;

import java.io.IOException;
import java.io.Serializable;
import java.net.HttpURLConnection;
import java.net.MalformedURLException;
import java.net.URL;
import java.util.Scanner;
import java.util.Vector;
import org.json.simple.JSONObject;
import org.json.simple.parser.JSONParser;
import org.json.simple.parser.ParseException;

public class MessageObject implements Serializable{
    private String info;
    
    public String getMessage(String signo) throws MalformedURLException, IOException, ParseException{
        URL url = new URL("http://horoscope-api.herokuapp.com/horoscope/today/" + signo );      
        HttpURLConnection conn = (HttpURLConnection)url.openConnection();
        conn.setRequestMethod("GET");
        conn.connect();
        int responsecode = conn.getResponseCode();
        if(responsecode != 200){
            throw new RuntimeException("HttpResponseCode:" + responsecode);
        }
        else{
            String inline = null;
            Scanner sc = new Scanner(url.openStream());
            while(sc.hasNext()){
                inline += sc.nextLine();
            }
            System.out.println("\nJSON data inline");
            System.out.println(inline);
            JSONParser parse = new JSONParser();
            JSONObject jobj = (JSONObject)parse.parse(inline);
            return (String) jobj.get("horoscope");
        }
    }
}
