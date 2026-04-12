package learnLanguage.learnLanguage.service;

import learnLanguage.learnLanguage.model.Accounts;
import learnLanguage.learnLanguage.repo.UserRepo;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.security.core.userdetails.UserDetails;
import org.springframework.security.core.userdetails.UserDetailsService;
import org.springframework.security.core.userdetails.UsernameNotFoundException;
import org.springframework.security.crypto.password.PasswordEncoder;
import org.springframework.stereotype.Service;


@Service
public class UserService implements UserDetailsService {
    @Autowired
    private UserRepo userRepo;
    @Autowired
    private PasswordEncoder passwordEncoder;

    public boolean Register(Accounts user){
        try {
            user.setPassword(passwordEncoder.encode(user.getPassword()));

            System.out.println("Haslo po szyfrowaniu: " + user.getPassword());
            userRepo.save(user);
            return true;
        }
        catch (Exception e){
            System.out.println("Błąd " + e.getMessage());
            return false;
        }
    }

    @Override
    public UserDetails loadUserByUsername(String username) throws UsernameNotFoundException {
        return userRepo.findByUsername(username)
                .orElseThrow(() -> new UsernameNotFoundException("User not found " + username));

    }
}
