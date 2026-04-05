package learnLanguage.learnLanguage.Repo;

import learnLanguage.learnLanguage.Model.Accounts;
import org.springframework.data.jpa.repository.JpaRepository;

import java.math.BigInteger;

public interface UserRepo extends JpaRepository<Accounts, Integer> {
}
