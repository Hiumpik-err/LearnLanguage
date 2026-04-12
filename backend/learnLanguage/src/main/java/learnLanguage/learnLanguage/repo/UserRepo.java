package learnLanguage.learnLanguage.repo;

import learnLanguage.learnLanguage.model.Accounts;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import java.util.Optional;

@Repository
public interface UserRepo extends JpaRepository<Accounts, Integer> {
    //Accounts findByEmail(String email);
    Optional<Accounts> findByUsername(String username);
}
