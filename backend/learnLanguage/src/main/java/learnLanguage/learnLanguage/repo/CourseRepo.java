package learnLanguage.learnLanguage.repo;

import learnLanguage.learnLanguage.model.Course;
import org.springframework.data.mongodb.repository.MongoRepository;
import org.springframework.stereotype.Repository;

import java.util.Optional;

@Repository
public interface CourseRepo extends MongoRepository<Course, String> {
}
