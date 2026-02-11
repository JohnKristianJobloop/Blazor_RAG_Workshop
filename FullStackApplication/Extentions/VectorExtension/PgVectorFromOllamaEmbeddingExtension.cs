using System;
using Pgvector;

namespace FullStackApplication.Extentions.VectorExtension;

public static class PgVectorFromOllamaEmbeddingExtension
{
    extension(Vector vector)
    {
        public Vector CreateFromEmbedding(IList<double> embeddings)
        {
            return new Vector(embeddings.Select(d => (float)d).ToArray());
        }
    }
}
