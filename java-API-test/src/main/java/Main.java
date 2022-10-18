import org.json.simple.JSONArray;
import org.json.simple.parser.JSONParser;

import java.net.HttpURLConnection;
import java.net.URL;
import java.net.MalformedURLException;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {

        try {
            //Public API: DnD 5e API
            //https://www.dnd5eapi.co/api
            URL url = new URL("https://www.dnd5eapi.co/api/ability-scores/cha");

            HttpURLConnection conn = (HttpURLConnection) url.openConnection();
            conn.setRequestMethod("GET");
            conn.connect();

            int responseCode = conn.getResponseCode();

            if(responseCode != 200) {
                throw new RuntimeException("HttpResponseCode: " + responseCode);
            }
            else {
                StringBuilder informationString = new StringBuilder();
                Scanner scanner = new Scanner(url.openStream());

                while (scanner.hasNext()) {
                    informationString.append(scanner.nextLine());
                }
                scanner.close();

                System.out.println(informationString);
        }

        } catch (Exception e) {
            e.printStackTrace();
        }
    }
}
