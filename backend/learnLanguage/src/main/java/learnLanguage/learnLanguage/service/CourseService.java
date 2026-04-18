package learnLanguage.learnLanguage.service;

import learnLanguage.learnLanguage.model.Course;
import learnLanguage.learnLanguage.repo.CourseRepo;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class CourseService {

    @Autowired
    CourseRepo courseRepo;

    public Course GetCourse(String id){
        try{
            var course = courseRepo.findById(id);
            if(course.isPresent()) {
                System.out.println("Element: " + course.toString());
                return course.get();
            }
            throw new Exception("element jest pusyt");
        }
        catch (Exception ex){
            System.out.println("Blad: " + ex.getMessage());
            return null;
        }
    }

}
