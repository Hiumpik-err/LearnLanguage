package learnLanguage.learnLanguage.Model;

import jakarta.persistence.*;

import java.util.List;

public class Course {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private int id;
    private String name;
    private String level;
    private String country;
    private String capitalImage;
    @ElementCollection
    private List<Word> data;


}
