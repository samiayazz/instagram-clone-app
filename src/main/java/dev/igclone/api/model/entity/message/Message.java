package dev.igclone.api.model.entity.message;

import dev.igclone.api.model.entity.common.UpdatableEntity;
import jakarta.persistence.Entity;
import jakarta.persistence.Inheritance;
import jakarta.persistence.InheritanceType;
import jakarta.persistence.Table;
import jakarta.validation.constraints.Max;
import jakarta.validation.constraints.NotBlank;
import jakarta.validation.constraints.Size;

@Entity
@Inheritance(strategy = InheritanceType.JOINED)
@Table(name = "messages")
public class Message extends UpdatableEntity {
    @NotBlank
    @Max(150)
    private String text;

    /*@Enumerated(EnumType.STRING)
    private MessageType messageType;*/

    @Size(min = 5, max = 150)
    private String mediaPath;

    public Message(String text) {
        this.text = text;
    }

    public Message(String text, String mediaPath) {
        this(text);
        this.mediaPath = mediaPath;
    }

    public String getText() {
        return text;
    }

    public void setText(String text) {
        this.text = text;
    }

    public String getMediaPath() {
        return mediaPath;
    }

    public void setMediaPath(String mediaPath) {
        this.mediaPath = mediaPath;
    }
}
