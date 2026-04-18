package learnLanguage.learnLanguage.config;

import com.mongodb.client.MongoDatabase;
import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;
import org.springframework.data.mongodb.MongoDatabaseFactory;
import org.springframework.data.mongodb.core.MongoTemplate;
import org.springframework.data.mongodb.core.SimpleMongoClientDatabaseFactory;
import org.springframework.data.mongodb.repository.config.EnableMongoRepositories;

@Configuration
@EnableMongoRepositories(basePackages = "learnLanguage.learnLanguage.repo",
mongoTemplateRef = "mongoTemplate")
public class MongodbConfig {

    @Bean
    public MongoDatabaseFactory mongodbFactory(){
        return new SimpleMongoClientDatabaseFactory("mongodb://localhost:27017/VocabularyBank");
    }
    @Bean
    public MongoTemplate mongoTemplate(){
        return new MongoTemplate(mongodbFactory());
    }
}
