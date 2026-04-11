package learnLanguage.learnLanguage.Service;

import learnLanguage.learnLanguage.Model.Accounts;
import learnLanguage.learnLanguage.Repo.UserRepo;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class UserService {
    @Autowired
    private UserRepo userRepo;

    public boolean Register(Accounts user){
        try {
            userRepo.save(user);
            return true;
        }
        catch (Exception e){
            System.out.println("Błąd " + e.getMessage());
            return false;
        }
    }
    public boolean LoginByEmail(String email, String password){
        try {
            Accounts user = userRepo.findByEmail(email);
            return user != null ? user.getPassword().equals(password) : false;
        }
        catch (Exception e){
            return false;
        }
    }

    public boolean LoginByUsername(String username, String password){
        try {
            Accounts user = userRepo.findByUsername(username);
            return user != null ? user.getPassword().equals(password) : false;
        }
        catch (Exception e){
            return false;
        }
    }


}
