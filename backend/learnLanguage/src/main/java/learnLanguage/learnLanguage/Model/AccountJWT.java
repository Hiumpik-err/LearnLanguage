package learnLanguage.learnLanguage.Model;

import io.jsonwebtoken.Jwts;
import io.jsonwebtoken.SignatureAlgorithm;
import io.jsonwebtoken.io.Decoders;
import io.jsonwebtoken.security.Keys;
import org.springframework.stereotype.Component;

import java.security.Key;
import java.util.Date;
import java.util.HashMap;
import java.util.Map;

@Component
public class AccountJWT {
    public String GenerateJWT(Accounts user){
        Map<String, Object> claims = new HashMap<>();
        return Jwts.builder()
                .setClaims(claims)
                .setSubject(user.getEmail())
                .setIssuedAt(new Date(System.currentTimeMillis()))
                .setExpiration(new Date(System.currentTimeMillis() + (1000 * 60 * 60)))
                .signWith(getSignWith(), SignatureAlgorithm.HS256)
                .compact();
    }

    private Key getSignWith(){
        String secretKey = "ajlshdfkjahsdfvano12346129dfgasjhgdhfakjsd#@$sadfas@#43dfa214asdf";
        byte[] keyBytes = Decoders.BASE64.decode((secretKey));
        return Keys.hmacShaKeyFor(keyBytes);
    }
}
