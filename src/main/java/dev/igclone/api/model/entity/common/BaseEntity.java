package dev.igclone.api.model.entity.common;

import jakarta.persistence.GeneratedValue;
import jakarta.persistence.GenerationType;
import jakarta.persistence.Id;
import jakarta.persistence.MappedSuperclass;

import java.time.LocalDateTime;
import java.util.UUID;

@MappedSuperclass
public abstract class BaseEntity {
    @Id
    @GeneratedValue(strategy = GenerationType.UUID)
    private UUID id;

    private LocalDateTime dateOfCreation = LocalDateTime.now();

    public UUID getId() {
        return id;
    }

    public LocalDateTime getDateOfCreation() {
        return dateOfCreation;
    }
}
