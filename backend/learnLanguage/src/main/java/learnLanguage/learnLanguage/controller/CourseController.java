package learnLanguage.learnLanguage.controller;

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

    @GetMapping("/courses")
    public ResponseEntity<?> GetAllCourses(){
        return new ResponseEntity<>("Dokoncz to", HttpStatus.OK);
    }
    @GetMapping("/courses/{id}")
    public ResponseEntity<?> getCourse(@PathVariable int id){
        return new ResponseEntity<>("Dokoncz to", HttpStatus.OK);
    }
}
