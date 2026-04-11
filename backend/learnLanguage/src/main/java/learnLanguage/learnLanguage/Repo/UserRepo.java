package learnLanguage.learnLanguage.Repo;

import learnLanguage.learnLanguage.Model.Accounts;
import org.springframework.data.jpa.repository.JpaRepository;


public interface UserRepo extends JpaRepository<Accounts, Integer> {
    Accounts findByEmail(String email);
    Accounts findByUsername(String username);
}
