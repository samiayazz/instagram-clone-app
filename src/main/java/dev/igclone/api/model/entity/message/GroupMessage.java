package dev.igclone.api.model.entity.message;

import dev.igclone.api.model.entity.Group;
import jakarta.persistence.Entity;
import jakarta.persistence.ManyToOne;
import jakarta.persistence.Table;

@Entity
@Table(name = "group_messages")
public class GroupMessage extends Message {
    @ManyToOne
    //@JoinColumn(name = "group_id")
    private Group group;

    public GroupMessage(String text, Group group) {
        super(text);
        this.group = group;
    }

    public GroupMessage(String text, String mediaPath, Group group) {
        super(text, mediaPath);
        this.group = group;
    }

    public Group getGroup() {
        return group;
    }
}
