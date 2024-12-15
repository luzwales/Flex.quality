using Flex.Quality.FreeSqlReppsitory.Tests;
using Flex.Quality.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flex.Quality
{
    public abstract class QualityFreeSqlRepositoryTestBase: QualityTestBase<QualityFreeSqlRepositoryTestModule>
    {
        public QualityFreeSqlRepositoryTestBase()
        {
            ServiceProvider.InitializeLocalization();
        }
    }
}
