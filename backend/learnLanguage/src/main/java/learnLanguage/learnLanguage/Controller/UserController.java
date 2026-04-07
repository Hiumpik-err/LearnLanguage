package learnLanguage.learnLanguage.Controller;

import learnLanguage.learnLanguage.Model.Accounts;
import learnLanguage.learnLanguage.Service.UserService;
import org.apache.coyote.Response;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.net.http.HttpResponse;

@CrossOrigin
@RestController
@RequestMapping("/api")
public class UserController {

    @Autowired
    private UserService userService;

    @PostMapping("/register")
    public ResponseEntity<?> Register(@RequestBody Accounts user){
        if(userService.Register(user)){
            return new ResponseEntity<>("User registered Successfully", HttpStatus.CREATED);
        }
        return new ResponseEntity<>("User failed to register", HttpStatus.BAD_REQUEST);
    }
    @PostMapping("/login")
    public ResponseEntity<?> Login(@RequestBody Accounts user){
        return new ResponseEntity("Logged in successfully", HttpStatus.OK);
    }

}
