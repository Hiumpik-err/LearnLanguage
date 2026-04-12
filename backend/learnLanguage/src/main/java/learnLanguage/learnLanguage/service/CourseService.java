package learnLanguage.learnLanguage.service;

import learnLanguage.learnLanguage.model.Word;
import org.springframework.stereotype.Service;

import java.util.ArrayList;
import java.util.List;

@Service
public class CourseService {


    public List<List<Word>>GetAllCourses(){
        return new ArrayList<>();
    }

    public List<Word> GetCourse(){
        return new ArrayList<>();
    }
}
