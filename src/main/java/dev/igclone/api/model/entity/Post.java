package dev.igclone.api.model.entity;

import dev.igclone.api.model.entity.common.UpdatableEntity;
import dev.igclone.api.model.enumeration.PostType;
import jakarta.persistence.*;
import jakarta.validation.constraints.Max;
import jakarta.validation.constraints.NotNull;
import jakarta.validation.constraints.Size;

@Entity
@Table(name = "posts")
public class Post extends UpdatableEntity {
    @NotNull
    @Enumerated(EnumType.STRING)
    private PostType postType;
    @Size(min = 5, max = 150)
    private String mediaPath;
    @ManyToOne
    //@JoinColumn(name = "audio_id")
    private Audio audio;
    @Max(150)
    private String text;

    @ManyToOne
    //@JoinColumn(name = "created_by_id")
    private User createdBy;

    private Post(PostBuilder builder) {
        this.postType = builder.postType;
        this.mediaPath = builder.mediaPath;
        this.audio = builder.audio;
        this.text = builder.text;
    }

    public PostType getPostType() {
        return postType;
    }

    public void setPostType(PostType postType) {
        this.postType = postType;
    }

    public String getMediaPath() {
        return mediaPath;
    }

    public Audio getAudio() {
        return audio;
    }

    public void setAudio(Audio audio) {
        this.audio = audio;
    }

    public String getText() {
        return text;
    }

    public static class PostBuilder {
        private PostType postType;
        private String mediaPath;
        private Audio audio;
        private String text;

        public PostBuilder(PostType postType) {
            this.postType = postType;
        }

        public PostBuilder setAudio(Audio audio) {
            this.audio = audio;
            return this;
        }

        public Post buildMediaPost(String mediaPath) {
            this.mediaPath = mediaPath;
            return new Post(this);
        }

        public Post buildMediaPost(String mediaPath, String text) {
            this.mediaPath = mediaPath;
            this.text = text;
            return new Post(this);
        }

        public Post buildTextPost(String text) {
            this.text = text;
            return new Post(this);
        }
    }
}
