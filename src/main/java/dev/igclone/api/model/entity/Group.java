package dev.igclone.api.model.entity;

import dev.igclone.api.model.entity.common.UpdatableEntity;
import jakarta.persistence.*;
import jakarta.validation.constraints.Max;
import jakarta.validation.constraints.NotBlank;
import jakarta.validation.constraints.Size;

import java.util.List;

@Entity
@Table(name = "groups")
public class Group extends UpdatableEntity {
    @NotBlank
    @Size(min = 3, max = 50)
    private String name;
    @Max(250)
    private String about;

    @ManyToOne
    //@JoinColumn(name = "created_by_id")
    private User createdBy;

    @ManyToMany(fetch = FetchType.LAZY)
    /*@JoinTable(
            name = "groups_users",
            joinColumns = {@JoinColumn(name = "group_id")},
            inverseJoinColumns = {@JoinColumn(name = "user_id")}
    )*/
    private List<User> members;

    public Group(String name) {
        this.name = name;
    }

    public Group(String name, String about) {
        this(name);
        this.about = about;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getAbout() {
        return about;
    }

    public void setAbout(String about) {
        this.about = about;
    }
}
