package dev.igclone.api.model.entity;

import dev.igclone.api.model.entity.common.UpdatableEntity;
import jakarta.persistence.*;
import jakarta.validation.constraints.Max;
import jakarta.validation.constraints.NotBlank;

import java.util.List;

@Entity
@Table(name = "comments")
public class Comment extends UpdatableEntity {
    @NotBlank
    @Max(100)
    private String text;

    @ManyToOne
    //@JoinColumn(name = "post_id")
    private Post post;

    @ManyToOne(fetch = FetchType.LAZY)
    //@JoinColumn(name = "parent_id", referencedColumnName = "id")
    private Comment parent;

    @OneToMany(mappedBy = "parent", fetch = FetchType.LAZY)
    private List<Comment> replies;

    @ManyToOne
    //@JoinColumn(name = "created_by_id")
    private User createdBy;

    private Comment(CommentBuilder builder) {
        this.text = builder.text;
        this.post = builder.post;
        this.parent = builder.parent;
    }

    public String getText() {
        return text;
    }

    public void setText(String text) {
        this.text = text;
    }

    public Post getPost() {
        return post;
    }

    public Comment getParent() {
        return parent;
    }

    public List<Comment> getReplies() {
        return replies;
    }

    public static class CommentBuilder {
        private String text;
        private Post post;
        private Comment parent;

        public CommentBuilder(String text, Post post) {
            this.text = text;
            this.post = post;
        }

        public Comment build() {
            return new Comment(this);
        }

        public Comment buildReply(Comment parent) {
            this.parent = parent;
            return new Comment(this);
        }
    }
}
