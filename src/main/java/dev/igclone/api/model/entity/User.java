package dev.igclone.api.model.entity;

import dev.igclone.api.model.entity.common.SoftDeletableEntity;
import dev.igclone.api.model.enumeration.Gender;
import jakarta.persistence.*;
import jakarta.validation.constraints.*;

import java.time.LocalDateTime;
import java.util.List;

@Entity
@Table(name = "users")
public class User extends SoftDeletableEntity {
    @NotBlank
    @Size(min = 2, max = 50)
    private String username;
    @NotNull
    @Email
    private String email;
    @NotBlank
    @Size(min = 8, max = 64)
    private String password;

    @NotBlank
    @Size(min = 2, max = 50)
    private String name;
    @NotBlank
    @Size(min = 2, max = 50)
    private String surname;
    @NotNull
    private LocalDateTime dateOfBirth;
    @NotNull
    @Enumerated(EnumType.STRING)
    private Gender gender = Gender.OTHER;

    @Max(250)
    private String about;

    @OneToMany(mappedBy = "createdBy")
    private List<Post> posts;

    @OneToMany(mappedBy = "createdBy")
    private List<Audio> audios;

    //region constructor
    public User(String username, String email, String password, String name, String surname, LocalDateTime dateOfBirth) {
        this.username = username;
        this.email = email;
        this.password = password;
        this.name = name;
        this.surname = surname;
        this.dateOfBirth = dateOfBirth;
    }

    public User(String username, String email, String password, String name, String surname, LocalDateTime dateOfBirth, Gender gender, String about) {
        this(username, email, password, name, surname, dateOfBirth);
        this.gender = gender;
        this.about = about;
    }
    //endregion

    //region getter & setter
    public String getUsername() {
        return username;
    }

    public void setUsername(String username) {
        this.username = username;
    }

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    public String getPassword() {
        return password;
    }

    public void setPassword(String password) {
        this.password = password;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getSurname() {
        return surname;
    }

    public void setSurname(String surname) {
        this.surname = surname;
    }

    public String getFullName() {
        return String.format("%s %s", name, surname);
    }

    public Gender getGender() {
        return gender;
    }

    public void setGender(Gender gender) {
        this.gender = gender;
    }

    public LocalDateTime getDateOfBirth() {
        return dateOfBirth;
    }

    public void setDateOfBirth(LocalDateTime dateOfBirth) {
        this.dateOfBirth = dateOfBirth;
    }

    public String getAbout() {
        return about;
    }

    public void setAbout(String about) {
        this.about = about;
    }
    //endregion
}
