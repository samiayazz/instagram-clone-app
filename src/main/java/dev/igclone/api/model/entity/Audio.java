package dev.igclone.api.model.entity;

import dev.igclone.api.model.entity.common.BaseEntity;
import dev.igclone.api.model.enumeration.PostType;
import jakarta.persistence.Entity;
import jakarta.persistence.ManyToOne;
import jakarta.persistence.OneToMany;
import jakarta.persistence.Table;
import jakarta.validation.constraints.NotBlank;
import jakarta.validation.constraints.Size;

import java.util.List;

@Entity
@Table(name = "audios")
public class Audio extends BaseEntity {
    @NotBlank
    @Size(min = 5, max = 150)
    private String audioPath;

    @OneToMany(mappedBy = "audio")
    private List<Post> posts;

    @ManyToOne
    //@JoinColumn(name = "created_by_id")
    private User createdBy;

    public Audio() {
        Post post = new Post.PostBuilder(PostType.FLOW).setAudio(null).buildMediaPost("mediaPath");
    }
}
