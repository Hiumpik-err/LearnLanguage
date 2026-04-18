package learnLanguage.learnLanguage.controller;

import learnLanguage.learnLanguage.model.Course;
import learnLanguage.learnLanguage.service.CourseService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

@CrossOrigin
@RestController
@RequestMapping("/api")
public class CourseController {

    @Autowired
    private CourseService courseService;

    @GetMapping("/courses/{id}")
    public ResponseEntity<?> GetCourse(@PathVariable String id){
        Course course = courseService.GetCourse(id);
        if(course != null){
            return new ResponseEntity<>(course, HttpStatus.OK);
        }
        return new ResponseEntity<>("Operacja nieudana GET(mongoDB)", HttpStatus.NOT_FOUND);
    }


}
