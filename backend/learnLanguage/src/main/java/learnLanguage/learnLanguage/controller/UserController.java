package learnLanguage.learnLanguage.controller;

import learnLanguage.learnLanguage.model.Accounts;
import learnLanguage.learnLanguage.service.UserService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.HttpStatusCode;
import org.springframework.http.ResponseEntity;
import org.springframework.security.authentication.AuthenticationManager;
import org.springframework.security.authentication.UsernamePasswordAuthenticationToken;
import org.springframework.security.core.Authentication;
import org.springframework.web.bind.annotation.*;

@CrossOrigin
@RestController
@RequestMapping("/api")
public class UserController {

    @Autowired
    private UserService userService;

    @Autowired
    private AuthenticationManager authManager;

    @PostMapping("/register")
    public ResponseEntity<?> Register(@RequestBody Accounts user){
        if(userService.Register(user)){
            return new ResponseEntity<>("User registered Successfully", HttpStatus.CREATED);
        }
        return new ResponseEntity<>("User failed to register", HttpStatus.BAD_REQUEST);
    }

   /* @PostMapping("/login")
    public ResponseEntity<?> Login(@RequestBody Accounts user){
        try {
            System.out.println("Haslo: " + user.getPassword());
            UsernamePasswordAuthenticationToken token = new UsernamePasswordAuthenticationToken(
                    user.getUsername(), user.getPassword()
            );

            Authentication auth = authManager.authenticate(token);
            return new ResponseEntity("Logged in successfully", HttpStatusCode.valueOf(200));


        }
        catch (Exception ex){
            System.out.println("Blad " + ex.getMessage() );
            return new ResponseEntity("Something went wrong", HttpStatus.NOT_FOUND);
        }
    }*/


}
