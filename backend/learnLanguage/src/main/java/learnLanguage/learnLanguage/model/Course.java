package learnLanguage.learnLanguage.model;


import org.springframework.data.annotation.Id;
import org.springframework.data.mongodb.core.mapping.Document;

import java.util.Map;

@Document(collection = "VocabularyBank")
public class Course {
    @Id
    private String id;
    private String name;
    private String level;
    private String country;
    private Map<String, Object> data;

    @Override
    public String toString() {
        return "Course{" +
                "name='" + name + '\'' +
                ", level='" + level + '\'' +
                ", country='" + country + '\'' +
                '}';
    }

    public Course() {}

    public Course(String id, String name, String level, String country, Map<String, Object> data) {
        this.id = id;
        this.name = name;
        this.level = level;
        this.country = country;
        this.data = data;
    }

    public String getId() {
        return id;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getLevel() {
        return level;
    }

    public void setLevel(String level) {
        this.level = level;
    }

    public String getCountry() {
        return country;
    }

    public void setCountry(String country) {
        this.country = country;
    }

    public Map<String, Object> getData() {
        return data;
    }

    public void setData(Map<String, Object> data) {
        this.data = data;
    }
}
