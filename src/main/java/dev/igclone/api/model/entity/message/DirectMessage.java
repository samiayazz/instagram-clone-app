package dev.igclone.api.model.entity.message;

import dev.igclone.api.model.entity.User;
import jakarta.persistence.Entity;
import jakarta.persistence.ManyToOne;
import jakarta.persistence.Table;

@Entity
@Table(name = "direct_messages")
public class DirectMessage extends Message {
    @ManyToOne
    //@JoinColumn(name = "recipient_id")
    private User recipient;

    public DirectMessage(String text, User recipient) {
        super(text);
        this.recipient = recipient;
    }

    public DirectMessage(String text, String mediaPath, User recipient) {
        super(text, mediaPath);
        this.recipient = recipient;
    }

    public User getRecipient() {
        return recipient;
    }
}
